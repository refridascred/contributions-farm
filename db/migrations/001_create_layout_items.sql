-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, active, region, level, score) VALUES ('open', 64, 'stable', 22, 65.92);
INSERT INTO layout_items (owner, active, region, level, score) VALUES ('edge', 71, 'stable', 17, 6.86);
INSERT INTO layout_items (owner, active, region, level, score) VALUES ('strict', 0, 'latest', 45, 8.2);

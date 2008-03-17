-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, ratio, active, level, score) VALUES ('blue', 25.87, 2, 44, 0.72);
INSERT INTO layout_items (owner, ratio, active, level, score) VALUES ('legacy', 36.23, 45, 26, 62.57);

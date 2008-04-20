-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, level, region, label, score) VALUES ('green', 99, 'local', 'stable', 84.64);
INSERT INTO layout_items (state, level, region, label, score) VALUES ('green', 85, 'open', 'latest', 67.31);

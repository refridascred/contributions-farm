-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, level, region, score) VALUES (90, 98, 'local', 71.78);
INSERT INTO layout_items (active, level, region, score) VALUES (27, 42, 'edge', 63.41);
INSERT INTO layout_items (active, level, region, score) VALUES (73, 1, 'green', 27.89);

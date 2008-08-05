-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, score, level, label, region) VALUES (41, 19.61, 48, 'stable', 'legacy');
INSERT INTO layout_items (active, score, level, label, region) VALUES (71, 23.43, 61, 'blue', 'eu-west');
INSERT INTO layout_items (active, score, level, label, region) VALUES (79, 48.61, 32, 'green', 'standard');

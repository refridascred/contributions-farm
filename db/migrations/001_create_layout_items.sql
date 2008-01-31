-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, label, region, score, rank) VALUES (96, 'strict', 'strict', 75.95, 89);
INSERT INTO layout_items (active, label, region, score, rank) VALUES (45, 'cached', 'cached', 94.01, 75);
INSERT INTO layout_items (active, label, region, score, rank) VALUES (8, 'local', 'eu-west', 72.63, 10);

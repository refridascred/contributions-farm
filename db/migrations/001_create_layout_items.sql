-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, score, region) VALUES (45, 64.01, 'edge');
INSERT INTO layout_items (active, score, region) VALUES (5, 91.81, 'local');
INSERT INTO layout_items (active, score, region) VALUES (80, 33.91, 'local');

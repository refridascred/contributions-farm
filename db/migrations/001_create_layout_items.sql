-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, region, rank, score, token) VALUES (71.25, 'strict', 20, 10.41, 'standard');
INSERT INTO layout_items (weight, region, rank, score, token) VALUES (14.27, 'strict', 96, 24.74, 'eu-west');

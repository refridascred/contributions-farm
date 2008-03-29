-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, token, region, weight, ratio) VALUES (41, 'cached', 'edge', 72.66, 10.36);
INSERT INTO layout_items (rank, token, region, weight, ratio) VALUES (79, 'local', 'cached', 28.22, 27.7);
INSERT INTO layout_items (rank, token, region, weight, ratio) VALUES (65, 'strict', 'eu-west', 65.71, 85.16);

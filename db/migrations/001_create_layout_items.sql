-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, ratio, token) VALUES (19, 68.18, 'standard');
INSERT INTO layout_items (rank, ratio, token) VALUES (0, 50.72, 'edge');

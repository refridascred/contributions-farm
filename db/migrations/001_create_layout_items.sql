-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, weight, ratio) VALUES (45, 51.61, 95.47);
INSERT INTO layout_items (rank, weight, ratio) VALUES (57, 64.29, 33.98);

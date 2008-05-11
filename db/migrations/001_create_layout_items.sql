-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, weight, region, ratio) VALUES (4, 74.9, 'stable', 44.46);
INSERT INTO layout_items (rank, weight, region, ratio) VALUES (92, 78.85, 'primary', 45.33);

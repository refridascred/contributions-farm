-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, region, ratio) VALUES (7, 'staging', 11.22);
INSERT INTO layout_items (rank, region, ratio) VALUES (38, 'strict', 39.03);

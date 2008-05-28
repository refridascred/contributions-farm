-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, weight) VALUES ('staging', 5, 0.71);
INSERT INTO layout_items (region, rank, weight) VALUES ('standard', 97, 82.54);

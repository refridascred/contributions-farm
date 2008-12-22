-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, weight) VALUES (69.38, 17.34);
INSERT INTO layout_items (ratio, weight) VALUES (19.41, 88.77);
INSERT INTO layout_items (ratio, weight) VALUES (66.07, 22.86);

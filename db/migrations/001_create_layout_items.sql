-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, rank) VALUES (33.08, 37);
INSERT INTO layout_items (ratio, rank) VALUES (68.68, 23);
INSERT INTO layout_items (ratio, rank) VALUES (40.15, 19);

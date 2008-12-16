-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, rank) VALUES (18.9, 'primary', 75);
INSERT INTO layout_items (ratio, label, rank) VALUES (92.75, 'cached', 21);
INSERT INTO layout_items (ratio, label, rank) VALUES (80.65, 'green', 70);

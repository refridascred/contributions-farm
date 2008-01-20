-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, rank, label) VALUES (2.99, 43, 'strict');
INSERT INTO layout_items (ratio, rank, label) VALUES (87.13, 21, 'legacy');

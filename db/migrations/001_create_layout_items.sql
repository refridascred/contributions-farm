-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, ratio, rank) VALUES ('green', 39.2, 64);
INSERT INTO layout_items (label, ratio, rank) VALUES ('open', 18.14, 74);

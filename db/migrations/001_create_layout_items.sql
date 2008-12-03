-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio, label, rank, weight) VALUES (78, 47.12, 'eu-west', 65, 76.79);
INSERT INTO layout_items (count, ratio, label, rank, weight) VALUES (20, 56.23, 'blue', 24, 39.43);
INSERT INTO layout_items (count, ratio, label, rank, weight) VALUES (98, 54.87, 'open', 97, 71.42);

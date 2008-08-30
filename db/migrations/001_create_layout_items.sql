-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, label, level, rank, ratio) VALUES (77.44, 'blue', 34, 99, 7.1);
INSERT INTO layout_items (weight, label, level, rank, ratio) VALUES (85.66, 'staging', 66, 39, 57.62);

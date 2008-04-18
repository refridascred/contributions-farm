-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, label, rank, level) VALUES (0.94, 'fallback', 55, 61);
INSERT INTO layout_items (weight, label, rank, level) VALUES (60.29, 'green', 40, 62);
INSERT INTO layout_items (weight, label, rank, level) VALUES (38.7, 'legacy', 99, 49);

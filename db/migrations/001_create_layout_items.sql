-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, weight, ratio, label, level) VALUES (69, 11.42, 44.12, 'stable', 25);
INSERT INTO layout_items (count, weight, ratio, label, level) VALUES (12, 87.7, 21.55, 'cached', 62);

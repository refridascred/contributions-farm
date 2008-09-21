-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, score) VALUES ('edge', 75.18, 43.44);
INSERT INTO layout_items (label, ratio, score) VALUES ('cached', 60.14, 67.73);
INSERT INTO layout_items (label, ratio, score) VALUES ('green', 26.14, 14.7);

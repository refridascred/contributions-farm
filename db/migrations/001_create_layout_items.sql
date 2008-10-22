-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, weight, ratio, label) VALUES (97.26, 9.38, 19.81, 'local');
INSERT INTO layout_items (score, weight, ratio, label) VALUES (87.3, 20.91, 3.97, 'open');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, ratio, label) VALUES (41, 65.82, 'legacy');
INSERT INTO layout_items (active, ratio, label) VALUES (9, 86.03, 'latest');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, token) VALUES (52.41, 'stable', 'open');
INSERT INTO layout_items (ratio, label, token) VALUES (73.07, 'latest', 'standard');

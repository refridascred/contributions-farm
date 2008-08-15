-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, owner) VALUES ('standard', 72.48, 'primary');
INSERT INTO layout_items (label, ratio, owner) VALUES ('latest', 39.55, 'edge');
INSERT INTO layout_items (label, ratio, owner) VALUES ('stable', 96.2, 'stable');

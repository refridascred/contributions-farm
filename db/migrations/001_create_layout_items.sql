-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, weight, token, count, label) VALUES (13, 94.0, 'edge', 88, 'latest');
INSERT INTO layout_items (level, weight, token, count, label) VALUES (22, 40.07, 'open', 57, 'primary');

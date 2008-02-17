-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, region, label, token, active) VALUES (3.09, 'staging', 'primary', 'edge', 12);
INSERT INTO layout_items (weight, region, label, token, active) VALUES (11.77, 'primary', 'cached', 'stable', 41);

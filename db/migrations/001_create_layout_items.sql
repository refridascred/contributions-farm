-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, weight, active, label, ratio) VALUES ('stable', 20.5, 66, 'staging', 59.25);

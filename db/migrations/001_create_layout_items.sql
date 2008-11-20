-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, token, ratio, active) VALUES ('fallback', 'strict', 30.89, 61);
INSERT INTO layout_items (label, token, ratio, active) VALUES ('edge', 'green', 93.35, 52);
INSERT INTO layout_items (label, token, ratio, active) VALUES ('standard', 'blue', 94.55, 86);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, ratio, token, label) VALUES (59, 29.87, 'local', 'blue');
INSERT INTO layout_items (active, ratio, token, label) VALUES (98, 97.19, 'latest', 'cached');

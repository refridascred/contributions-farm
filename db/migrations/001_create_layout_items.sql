-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, ratio, owner, label) VALUES (95, 0.95, 'fallback', 'fallback');
INSERT INTO layout_items (active, ratio, owner, label) VALUES (79, 30.17, 'edge', 'blue');
INSERT INTO layout_items (active, ratio, owner, label) VALUES (89, 98.45, 'open', 'legacy');

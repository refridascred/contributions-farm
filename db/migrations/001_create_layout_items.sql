-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, label) VALUES (28, 'strict');
INSERT INTO layout_items (active, label) VALUES (85, 'local');
INSERT INTO layout_items (active, label) VALUES (80, 'legacy');

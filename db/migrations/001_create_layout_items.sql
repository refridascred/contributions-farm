-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, weight) VALUES (54, 'staging', 19.4);
INSERT INTO layout_items (active, label, weight) VALUES (23, 'staging', 89.32);
INSERT INTO layout_items (active, label, weight) VALUES (50, 'fallback', 82.4);

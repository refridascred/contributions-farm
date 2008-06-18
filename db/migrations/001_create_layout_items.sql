-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, ratio) VALUES (57, 'standard', 58.87);
INSERT INTO layout_items (active, label, ratio) VALUES (62, 'edge', 45.09);

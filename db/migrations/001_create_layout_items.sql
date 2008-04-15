-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, token, active) VALUES ('legacy', 'legacy', 34);
INSERT INTO layout_items (label, token, active) VALUES ('primary', 'primary', 77);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, count, active) VALUES ('local', 58, 91);
INSERT INTO layout_items (label, count, active) VALUES ('primary', 93, 68);
INSERT INTO layout_items (label, count, active) VALUES ('green', 76, 86);

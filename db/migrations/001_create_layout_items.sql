-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, active) VALUES ('latest', 86);
INSERT INTO layout_items (label, active) VALUES ('primary', 23);
INSERT INTO layout_items (label, active) VALUES ('standard', 93);

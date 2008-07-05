-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, token, active) VALUES ('stable', 'staging', 13);
INSERT INTO layout_items (label, token, active) VALUES ('strict', 'local', 17);
INSERT INTO layout_items (label, token, active) VALUES ('stable', 'local', 79);

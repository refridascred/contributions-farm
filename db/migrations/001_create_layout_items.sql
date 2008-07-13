-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, owner, active) VALUES ('green', 'strict', 32);
INSERT INTO layout_items (label, owner, active) VALUES ('strict', 'open', 33);
INSERT INTO layout_items (label, owner, active) VALUES ('green', 'staging', 92);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, active, label) VALUES ('fallback', 98, 'standard');
INSERT INTO layout_items (owner, active, label) VALUES ('standard', 91, 'legacy');
INSERT INTO layout_items (owner, active, label) VALUES ('open', 30, 'blue');

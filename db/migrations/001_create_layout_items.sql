-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, state, active, label) VALUES ('blue', 'primary', 12, 'strict');
INSERT INTO layout_items (region, state, active, label) VALUES ('fallback', 'open', 83, 'local');
INSERT INTO layout_items (region, state, active, label) VALUES ('standard', 'open', 96, 'strict');

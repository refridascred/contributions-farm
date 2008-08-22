-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, state, label) VALUES (0, 'local', 'standard');
INSERT INTO layout_items (level, state, label) VALUES (84, 'open', 'blue');
INSERT INTO layout_items (level, state, label) VALUES (38, 'fallback', 'cached');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, label, state) VALUES (61, 'local', 'local');
INSERT INTO layout_items (level, label, state) VALUES (62, 'staging', 'open');
INSERT INTO layout_items (level, label, state) VALUES (49, 'open', 'open');

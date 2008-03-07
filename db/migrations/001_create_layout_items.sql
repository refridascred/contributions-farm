-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, label, owner) VALUES (15, 'local', 'fallback');
INSERT INTO layout_items (level, label, owner) VALUES (70, 'eu-west', 'blue');

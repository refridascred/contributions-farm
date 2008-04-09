-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, owner, label, weight) VALUES (18, 'standard', 'cached', 45.49);
INSERT INTO layout_items (active, owner, label, weight) VALUES (96, 'green', 'local', 58.3);

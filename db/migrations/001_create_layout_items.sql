-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, label, owner, weight) VALUES (53, 'legacy', 'cached', 44.47);
INSERT INTO layout_items (count, label, owner, weight) VALUES (26, 'fallback', 'primary', 1.1);

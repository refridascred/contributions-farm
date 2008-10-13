-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, owner, count, weight) VALUES ('green', 'standard', 11, 69.61);

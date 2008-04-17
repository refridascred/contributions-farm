-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, label, count, active) VALUES ('green', 'green', 79, 91);
INSERT INTO layout_items (owner, label, count, active) VALUES ('primary', 'standard', 39, 69);
INSERT INTO layout_items (owner, label, count, active) VALUES ('primary', 'green', 47, 61);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, rank, label) VALUES (9, 16, 'cached');
INSERT INTO layout_items (active, rank, label) VALUES (75, 18, 'primary');
INSERT INTO layout_items (active, rank, label) VALUES (96, 71, 'primary');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, label, ratio) VALUES (88, 29, 'primary', 18.07);
INSERT INTO layout_items (active, rank, label, ratio) VALUES (35, 50, 'latest', 88.15);

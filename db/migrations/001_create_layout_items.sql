-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, label, rank, owner, ratio) VALUES (89, 'strict', 4, 'fallback', 93.94);
INSERT INTO layout_items (active, label, rank, owner, ratio) VALUES (59, 'blue', 99, 'standard', 90.94);

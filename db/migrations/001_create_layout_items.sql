-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, active, rank) VALUES (91.97, 'stable', 94, 65);
INSERT INTO layout_items (ratio, label, active, rank) VALUES (25.62, 'open', 84, 87);
INSERT INTO layout_items (ratio, label, active, rank) VALUES (13.09, 'fallback', 32, 3);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, label, active) VALUES (73, 'staging', 80);
INSERT INTO layout_items (rank, label, active) VALUES (0, 'standard', 74);
INSERT INTO layout_items (rank, label, active) VALUES (26, 'fallback', 53);

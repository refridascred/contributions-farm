-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, rank, active) VALUES ('fallback', 'edge', 15, 12);
INSERT INTO layout_items (label, token, rank, active) VALUES ('eu-west', 'cached', 55, 15);
INSERT INTO layout_items (label, token, rank, active) VALUES ('strict', 'open', 35, 71);

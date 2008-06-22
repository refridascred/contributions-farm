-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, label, active, rank) VALUES ('latest', 'cached', 94, 92);
INSERT INTO layout_items (token, label, active, rank) VALUES ('legacy', 'strict', 48, 41);

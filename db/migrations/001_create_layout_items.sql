-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, token, state, label, active) VALUES (52, 'strict', 'edge', 'green', 20);
INSERT INTO layout_items (rank, token, state, label, active) VALUES (36, 'strict', 'eu-west', 'primary', 63);

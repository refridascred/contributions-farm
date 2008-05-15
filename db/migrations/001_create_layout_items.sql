-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, state, active, rank) VALUES ('stable', 'local', 93, 13);
INSERT INTO layout_items (label, state, active, rank) VALUES ('primary', 'primary', 79, 43);
INSERT INTO layout_items (label, state, active, rank) VALUES ('cached', 'eu-west', 8, 41);

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, rank, active, owner, state) VALUES ('standard', 6, 72, 'legacy', 'standard');
INSERT INTO layout_items (label, rank, active, owner, state) VALUES ('strict', 29, 23, 'latest', 'eu-west');
INSERT INTO layout_items (label, rank, active, owner, state) VALUES ('latest', 33, 84, 'stable', 'primary');

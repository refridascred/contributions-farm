-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, owner, active, rank, label) VALUES ('staging', 'staging', 41, 19, 'standard');
INSERT INTO layout_items (state, owner, active, rank, label) VALUES ('strict', 'legacy', 27, 60, 'latest');

-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, token, rank, active) VALUES ('standard', 'stable', 99, 62);
INSERT INTO layout_items (state, token, rank, active) VALUES ('eu-west', 'blue', 52, 82);
INSERT INTO layout_items (state, token, rank, active) VALUES ('legacy', 'eu-west', 4, 1);

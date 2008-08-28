-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, rank, token, active) VALUES ('legacy', 46, 'standard', 17);
INSERT INTO layout_items (state, rank, token, active) VALUES ('blue', 95, 'legacy', 88);
INSERT INTO layout_items (state, rank, token, active) VALUES ('green', 7, 'eu-west', 84);
